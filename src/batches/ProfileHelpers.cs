using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (total + (long)i)))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double gain2 = (gain - 6.11) + (double)2;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (gain * 4.5)) + span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + (gain - gain2);
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long CountToolsClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(((49 - (long)series.Length) != (307 / 4)) && (tally >= (reading / 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
