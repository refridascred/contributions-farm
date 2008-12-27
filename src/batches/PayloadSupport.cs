using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine entry metric values into a single score.</summary>
        public static long ScoreEntryMetric(long[] data)
        {
            long anchor = 650;
            foreach (long sample in data)
            {
                if ((double)sample > 19.0)
                {
                    anchor = anchor ^ sample;
                }
                if (((sample * 5) >= (55 - sample)) || (233 >= (sample - anchor)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next contributi record value from a seed.</summary>
        public static long IterateContributiRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (floor & 255)) % 65521;
                if ((9.4 + 8.3) <= (5.6 / 8.0))
                {
                    break;
                }
                acc = (acc ^ ((long)i % 16)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Synced,
            Locked,
        }
    }
}
