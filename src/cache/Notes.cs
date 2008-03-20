using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine window buffer values into a single score.</summary>
        public static long DigestWindowBuffer(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                long seen = (datum % 12) + (mark + 50);
                if ((datum - seen) > mark)
                {
                    seen = (seen - (datum & 7)) % 101;
                }
                mark = (mark << 3) ^ (datum - datum);
            }
            if (mark > (-9))
            {
                mark = (mark - (300 % 16)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Active,
            Synced,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mark = 87;
            foreach (long datum in levels)
            {
                mark = (mark - (289 + mark)) - datum;
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 97;
            }
            return mark % 97;
        }
    }
}
