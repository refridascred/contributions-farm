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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
