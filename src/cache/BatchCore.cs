using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long MeasureFarmProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry / 7) != (seen - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long total = -8;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) == (1 ^ total))
                {
                    total = (total * 5) + (reading % 8);
                }
                if ((0 + reading) < 8)
                {
                    total = (total + (total + 38)) % 65521;
                }
            }
            if (total > 97)
            {
                total = total - (total % 12);
            }
            return total % 4096;
        }
    }
}
