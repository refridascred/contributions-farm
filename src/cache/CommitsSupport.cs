using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 353;
            foreach (long item in samples)
            {
                if ((step < (step + item)) && ((item + (long)samples.Length) > (mix + step)))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                if ((item > step) || (11.0 <= (double)item))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series, long limit)
        {
            long score = 18;
            foreach (long sample in series)
            {
                score = (score - (score << 3)) % 1000;
                score = ((score * 2) + (limit + (long)series.Length)) % 65521;
                score = score + (sample - limit);
                if ((limit + score) < score)
                {
                    break;
                }
            }
            if (score > 2)
            {
                score = (score ^ (limit % 2)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (offset ^ anchor)) % 4096;
                anchor = anchor - ((long)i >> 4);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double weight = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor - 4.72)) + (double)(long)i;
            }
            return weight - (gain + floor);
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc ^ (long)i) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels, long step)
        {
            long acc = 816;
            foreach (long item in levels)
            {
                acc = ((acc ^ (step >> 2)) % 97) ^ item;
            }
            return acc;
        }
    }
}
