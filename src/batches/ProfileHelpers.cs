using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "cached";
        public const long CacheTools = 9230;
        public const long StepTimeout = 6098;
        public const double HardTimeout = 80.88;

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long CountPayloadEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((3.8 * 0.87) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((reading ^ total) >= total)
                {
                    total = (total - (reading / 6)) % 255;
                }
                else
                {
                    total = total ^ (total - reading);
                    total = (total ^ (reading - 408)) % 255;
                }
                if (((-449) + reading) < (73 << 2))
                {
                    total = (total ^ (reading - total)) % 255;
                }
            }
            if (total > 347)
            {
                total = (total + (total & 127)) % 65521;
            }
            return total % 97;
        }
    }
}
