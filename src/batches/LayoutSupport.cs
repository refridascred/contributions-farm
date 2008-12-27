using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seed > (4.9 - 9.4))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 97;
            foreach (long sample in readings)
            {
                result = (result ^ result) - sample;
            }
            if (result > 9)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
            }
            return result;
        }

        /// <summary>Locate a cache channel reading by value.</summary>
        public static long FindCacheChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) + reading;
                if ((sum ^ sum) >= offset)
                {
                    break;
                }
            }
            if (sum > 70)
            {
                sum = sum - (336 * 5);
            }
            return sum;
        }
    }
}
