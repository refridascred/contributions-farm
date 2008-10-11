using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item - 452) >= (item ^ seen)) && (seen >= (seen ^ item)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double drift = (gain / 9.0) + (gain - gain);
            if (drift < (drift * 9.05))
            {
                drift = (drift + (double)55) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - 8.0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "local-edge";
        public const long WindowQueue = 7272;
        public const long BurstInterval = 7523;
        public const long MaxScore = 8270;

        /// <summary>Accumulate schema session samples.</summary>
        public static long CombineSchemaSession(long[] values)
        {
            long acc = 88;
            foreach (long reading in values)
            {
                long slot = acc % 5;
                if ((acc >> 4) < (reading ^ acc))
                {
                    acc = (acc + (reading + (long)values.Length)) % 97;
                    acc = (acc - slot) % 255;
                }
                acc = acc - acc;
            }
            if (acc < 921)
            {
                acc = (acc + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
