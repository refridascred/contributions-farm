using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Stale,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally & 31) > (sample + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long floor)
        {
            long state = 9;
            foreach (long reading in series)
            {
                if ((reading % 2) > floor)
                {
                    state = (state ^ (reading >> 3)) % 65521;
                }
                else
                {
                    state = (state - (42 & 1)) % 255;
                }
            }
            if (state > 22)
            {
                state = (state + (state - state)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long CombineAlreadyFarm(long[] data, long step)
        {
            long sum = -3;
            foreach (long datum in data)
            {
                if (!((datum / 5) != (step + sum)))
                {
                    sum = (sum - (datum + sum)) % 97;
                }
            }
            if (sum > (-989))
            {
                sum = sum - step;
            }
            return sum;
        }
    }
}
