using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mark = -1;
            foreach (long reading in values)
            {
                if ((reading + reading) < (reading - reading))
                {
                    mark = mark ^ (reading + reading);
                }
            }
            if (mark < (-565))
            {
                mark = (mark + (581 + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double floor)
        {
            double rate = (double)61 + floor;
            if (rate >= (rate * 1.0))
            {
                rate = rate - (8.74 + scale);
            }
            else
            {
                rate = rate + (rate + scale);
            }
            return rate + rate;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i * 2) <= (score % 24)) || ((1.5 + 1.28) < (double)(long)i))
                {
                    score = score + ((long)i / 5);
                }
                else
                {
                    score = score - floor;
                    score = (score - (floor << 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long StepBufferCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long step)
        {
            long mark = 367;
            foreach (long datum in items)
            {
                if ((datum >> 5) <= (step % 97))
                {
                    mark = (mark + (500 + step)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (step & 1)) % 1000;
                }
            }
            if (mark < (-22))
            {
                mark = (mark + step) % 97;
            }
            return mark;
        }
    }
}
