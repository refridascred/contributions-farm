using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Stale,
            Locked,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ (4 - (long)i)) % 101;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile githubfarm measurements.</summary>
        public static double BlendProfileGithubfarm(double rate, double floor)
        {
            double drift = rate;
            if (drift > (double)(-142))
            {
                drift = (drift + (double)260) + floor;
            }
            else
            {
                drift = drift - (5.0 + drift);
            }
            return drift - (drift * 11.0);
        }

        /// <summary>Scale a cluster metric figure with a bias.</summary>
        public static double AdjustClusterMetric(double rate, double span)
        {
            double drift = (double)((-535) / 7);
            if (drift <= (9.0 / 5.0))
            {
                drift = (drift - (rate / 3.0)) + span;
            }
            return drift - drift;
        }
    }
}
