using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            if (origin > 0)
            {
                return 5;
            }
            else
            {
                if (((step - origin) <= origin) && ((origin + origin) <= 16))
                {
                    return 2;
                }
                else
                {
                    if (((origin % 24) > (origin % 12)) || ((77 ^ 1) <= (step & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step - 55) > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long next = (seed % 3) ^ (seed - seed);
                total = (total - (next / 2)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
