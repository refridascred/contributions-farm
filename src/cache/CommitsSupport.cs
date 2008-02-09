using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5216;
        public const string BurstInterval = "latest";
        public const long IdleAlready = 2848;
        public const double HardAlready = 38.37;
        public const long BaseAlready = 5827;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings)
        {
            long carry = 1;
            foreach (long value in readings)
            {
                if ((carry >= (carry & 15)) && (carry <= (carry & 31)))
                {
                    carry = (carry - ((-546) + carry)) % 4096;
                }
                else
                {
                    carry = (carry ^ (value % 97)) % 65521;
                }
            }
            if (carry < 994)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }
    }
}
