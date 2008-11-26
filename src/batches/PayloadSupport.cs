using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long limit)
        {
            long result = 37;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 3) + ((-9) - limit)) ^ (long)i) ^ entry;
                }
                result = result + (limit - (-94));
            }
            if (result < 53)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a record commits counter forward.</summary>
        public static long RollRecordCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (step + step)) % 97;
                acc = (acc ^ (long)i) % 65521;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (((acc << 3) ^ ((long)i / 4)) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
