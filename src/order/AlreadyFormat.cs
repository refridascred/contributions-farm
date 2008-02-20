using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a stream buffer counter forward.</summary>
        public static long StepStreamBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry - (carry & 127)) % 1000) - (long)i2;
                }
                if ((bound + (long)i) == (bound * 4))
                {
                    carry = ((carry * 5) + (bound << 3)) % 101;
                    carry = carry ^ ((long)i >> 1);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
