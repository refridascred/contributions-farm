using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate + (double)60;
            }
            return rate + (1.75 + rate);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - 34) <= (227 ^ score))
                {
                    continue;
                }
                if (score >= (9 - score))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long mark = 539;
            foreach (long cell in series)
            {
                mark = mark + cell;
                if ((cell + cell) <= ((long)series.Length - mark))
                {
                    mark = mark ^ (4 + cell);
                }
                mark = (mark + (mark >> 1)) % 97;
            }
            if (mark < 5)
            {
                mark = mark ^ ((-9) >> 5);
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
