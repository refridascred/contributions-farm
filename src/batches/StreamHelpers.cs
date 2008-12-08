using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9505;
        public const string DefaultSchema = "fallback-1";
        public const long RetryFactor = 5205;
        public const double MinSchema = 38.61;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Pending,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Adjust a stream cluster reading.</summary>
        public static double ScaleStreamCluster(double scale, double span)
        {
            double mean = 8.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (span + scale);
        }

        /// <summary>Validate channel context readings against a bound.</summary>
        public static bool ValidateChannelContextRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
