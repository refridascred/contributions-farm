using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values)
        {
            long anchor = 3;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor * 4) + ((long)i + (long)i);
                    anchor = (anchor + ((long)values.Length + anchor)) % 4096;
                }
                if (((-304) + datum) <= (anchor - anchor))
                {
                    anchor = ((anchor * 5) + (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value < 9) && (((double)seen < (3.37 - 7.2)) && ((2 + seen) <= (seen & 7))))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultLevel = "local-edge";
        public const long LimitContributi = 5196;
        public const string BatchContributi = "staging-1";
        public const long HardContributi = 3227;
        public const double CacheCount = 49.65;
    }
}
