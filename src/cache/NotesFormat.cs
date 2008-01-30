using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a batch buffer sample.</summary>
        public static long LocateBatchBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
