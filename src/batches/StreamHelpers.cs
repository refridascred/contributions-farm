using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + ((long)i ^ step)) % 101;
                if ((step >> 5) > (long)i)
                {
                    carry = ((carry << 2) ^ (carry % 8)) % 97;
                    carry = ((carry << 3) ^ ((long)i - step)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long score = 83;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (datum + datum)) - bound;
            }
            return score % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Weight { get; set; }
        }
    }
}
