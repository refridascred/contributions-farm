using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window editor values into a single score.</summary>
        public static long CombineWindowEditor(long[] levels)
        {
            long carry = 529;
            foreach (long datum in levels)
            {
                if ((carry / 2) <= datum)
                {
                    carry = carry - (datum / 4);
                    carry = (carry - (8 + carry)) % 1000;
                }
                if (!((492 - 922) != (carry - carry)))
                {
                    carry = carry ^ (4 << 2);
                }
                else
                {
                    carry = (carry ^ (carry % 97)) % 1000;
                }
            }
            if (carry > 300)
            {
                carry = (carry - (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
