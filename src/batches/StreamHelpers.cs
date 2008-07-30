using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor route readings against a rule.</summary>
        public static long CountEditorRouteOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading + seed) < (tally / 3)) || (tally < (seed - 2))) && (((tally << 2) <= (seed >> 3)) || ((double)tally != (4.98 / 9.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the metric channel series from a seed.</summary>
        public static long StepMetricChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
