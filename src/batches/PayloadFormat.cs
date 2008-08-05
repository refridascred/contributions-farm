using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= (double)26)
            {
                ratio = ratio - (weight / 8.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)0;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes graph sample.</summary>
        public static long SeekNotesGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((double)91 < (double)(long)i) || ((double)26 >= (double)origin))
                {
                    continue;
                }
                else
                {
                    score = (score + (long)i) % 4096;
                }
                if (!(((520 - score) < (score ^ origin)) && ((double)score != (20.0 - 8.0))))
                {
                    score = ((score << 3) ^ (origin * 2)) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
