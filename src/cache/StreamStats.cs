using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings, long limit)
        {
            long result = -940;
            foreach (long reading in readings)
            {
                if (reading <= (result & 1))
                {
                    result = (result + limit) % 97;
                }
                else
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long total = 31;
            foreach (long cell in readings)
            {
                if (((cell + total) > (total << 2)) && ((84 + cell) < (total << 3)))
                {
                    total = total - (total ^ 180);
                }
                else
                {
                    total = (total ^ (total % 64)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
