using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 8748;
        public const long WindowSize = 5264;
        public const long RetryReport = 2212;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSize = "latest-edge";
        public const string StepLayout = "local";
        public const double HardLayout = 71.73;
        public const string IdleLayout = "strict-edge";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor / 9) == (hits + hits))
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
