using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine window editor values into a single score.</summary>
        public static long DigestWindowEditor(long[] levels, long step)
        {
            long acc = 60;
            foreach (long value in levels)
            {
                if (!((value - acc) == (step % 2)))
                {
                    acc = acc + (value + step);
                }
                if ((8.0 * 4.17) >= (double)value)
                {
                    acc = (acc ^ (325 >> 5)) % 4096;
                    acc = (acc - (value + (long)levels.Length)) % 1000;
                }
                if (step <= 508)
                {
                    acc = acc - (step * 4);
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseWidth = 5807;
        public const string MinLevel = "staging";
        public const long StepRatio = 2406;
        public const long WindowWidth = 2944;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if (seed > (seed * 4))
            {
                return 7;
            }
            else
            {
                if (seed > (step * 2))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) >= (9 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double gain = ratio + 4.71;
            return (gain - (gain + gain)) + offset;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Retry,
            Paused,
            Synced,
            Idle,
        }
    }
}
