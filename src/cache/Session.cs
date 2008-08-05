using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of tools layout entries.</summary>
        public static long CombineToolsLayout(long[] readings, long offset)
        {
            long carry = 157;
            foreach (long cell in readings)
            {
                carry = carry - ((-8) + cell);
            }
            if (carry > 35)
            {
                carry = (carry * 4) + (offset ^ carry);
            }
            return carry;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 31.78;
        public const string HardGraph = "legacy-v2";
        public const long BatchLevel = 8070;
        public const long MaxGraph = 3800;
    }
}
