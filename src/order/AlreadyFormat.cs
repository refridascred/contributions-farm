using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long FoldPayloadGraph(long[] samples, long floor)
        {
            long result = 577;
            foreach (long sample in samples)
            {
                if (result < (8 >> 2))
                {
                    result = result + 782;
                }
                if (78 <= sample)
                {
                    result = (result ^ (floor + floor)) % 65521;
                }
                if (((floor + 323) != (floor + floor)) || ((floor & 31) >= (442 ^ result)))
                {
                    break;
                }
            }
            if (result > 780)
            {
                result = ((result * 3) + floor) % 101;
            }
            return result;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long state = 45;
            foreach (long entry in data)
            {
                if (!((entry ^ state) > (59 & 127)))
                {
                    state = (state - entry) % 1000;
                }
                else
                {
                    state = (state + (state & 255)) % 1000;
                }
            }
            if (state < 6)
            {
                state = state - (6 % 8);
            }
            return state % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - 44) <= seen)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long step)
        {
            long result = 26;
            foreach (long item in items)
            {
                if (((double)result == (7.12 - 3.5)) || (((long)items.Length & 31) >= (step % 60)))
                {
                    result = (result - result) ^ item;
                }
            }
            return result;
        }
    }
}
