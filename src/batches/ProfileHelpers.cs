using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values)
        {
            long mark = 31;
            foreach (long reading in values)
            {
                mark = ((mark ^ (mark * 5)) % 65521) + reading;
            }
            if (mark < 1)
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 609;
            foreach (long entry in values)
            {
                result = (result ^ ((-239) ^ entry)) % 65521;
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
