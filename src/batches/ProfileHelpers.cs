using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long CompareEditorNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count % 100) >= (item + 4)) || ((count + item) >= ((-7) + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((limit / 4) > (9 & 15)) || ((limit % 3) <= (carry + 2)))
                {
                    carry = (carry - (limit / 4)) % 4096;
                }
                carry = (carry + carry) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry ^ (limit * 5)) % 101) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ 19) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
