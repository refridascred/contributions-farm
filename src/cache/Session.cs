using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long mix = 561;
            foreach (long cell in series)
            {
                mix = mix - cell;
                if ((cell * 4) != (cell << 1))
                {
                    mix = (mix ^ mix) % 97;
                }
                else
                {
                    mix = (mix - (cell ^ cell)) % 101;
                }
                if ((mix >= cell) || ((cell >> 1) <= cell))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = mix + (785 % 24);
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}
