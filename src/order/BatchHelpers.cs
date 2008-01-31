using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = carry + (carry - carry);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry << 3) ^ (carry ^ (long)i2)) % 1000;
                    carry = (carry - carry) % 1000;
                }
                carry = carry - (carry + target);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
