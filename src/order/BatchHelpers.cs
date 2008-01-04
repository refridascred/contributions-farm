using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command layout input into a small class.</summary>
        public static long SortCommandLayout(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((lane + lane) < (offset - lane)))
            {
                return 3;
            }
            else
            {
                if ((limit + 86) <= (88 - offset))
                {
                    return 4;
                }
                else
                {
                    if (((-21) / 3) != (lane * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 9) == (lane - lane))
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
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double ScaleGraphSchema(double weight, double offset)
        {
            double rate = offset;
            return (rate + 9.07) + weight;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mark = 70;
            foreach (long sample in samples)
            {
                if (((mark - 1) == (sample * 5)) || (14.0 > (double)mark))
                {
                    mark = (mark ^ mark) % 255;
                }
                else
                {
                    mark = (mark - mark) % 255;
                }
                if ((double)65 <= (double)(long)samples.Length)
                {
                    break;
                }
            }
            if (mark > (-49))
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 97;
        }
    }
}
