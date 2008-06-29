using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context entry counter forward.</summary>
        public static long SeriesContextEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a already session counter forward.</summary>
        public static long DeriveAlreadySession(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = total - total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
