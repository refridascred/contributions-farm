using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double scale2 = (double)3 / 8.0;
            if (scale2 >= scale2)
            {
                scale2 = ((scale2 + (double)89) + scale) + offset;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 - 5.0;
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long ClassifyLayoutSchema(long origin, long target)
        {
            if ((0 ^ origin) > (target * 3))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin & 15) != (941 ^ target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next tools format value from a seed.</summary>
        public static long StepToolsFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - (7 * 2);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
