using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Dropped,
            New,
            Closed,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long offset)
        {
            long diff = seed - offset;
            if (!((double)diff != (3.53 + 12.0)))
            {
                return 0;
            }
            else
            {
                if (((3.76 - 7.25) == (double)offset) || ((0 - seed) < diff))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long target)
        {
            long acc = 586;
            foreach (long sample in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc << 2) ^ (2 / 5)) ^ (long)i;
                }
                if ((sample - acc) != (target + target))
                {
                    acc = ((acc << 3) ^ target) % 255;
                }
                else
                {
                    acc = (acc + (acc + acc)) % 255;
                }
                if ((sample <= (75 >> 3)) && ((405 + acc) != (3 + 2)))
                {
                    acc = (acc - 394) % 65521;
                }
                else
                {
                    acc = (acc - sample) % 65521;
                }
                if (((5 / 8) <= acc) || ((target + sample) >= target))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 2) ^ (689 + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
