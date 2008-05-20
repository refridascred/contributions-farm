using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long WeighNotesContributi(long[] values, long floor)
        {
            long total = 57;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 97;
                if ((total & 255) == (total + total))
                {
                    total = total + (65 + value);
                }
            }
            if (total < 5)
            {
                total = ((total << 2) ^ (floor + total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
