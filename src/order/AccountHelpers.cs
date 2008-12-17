using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)offset > 6.67)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long origin)
        {
            long state = -683;
            foreach (long reading in levels)
            {
                if (reading > (444 >> 4))
                {
                    state = (state ^ (origin / 5)) % 1000;
                }
            }
            if (state > (-515))
            {
                state = state - (-8);
            }
            return state;
        }

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long CombineChannelBatches(long[] data)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if (total > (total ^ 0))
                {
                    total = ((total << 2) ^ (total & 7)) % 1000;
                }
                else
                {
                    total = ((total * 2) + (sample + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
