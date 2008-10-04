using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (floor / 9.0)) + (double)(long)i) - bias;
            }
            return scale + (double)575;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long anchor = 7;
            foreach (long reading in levels)
            {
                if (anchor <= (anchor - bound))
                {
                    anchor = (anchor * 3) + (reading - 48);
                }
                if ((8.0 + 8.98) >= (double)reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((anchor * 5) <= (entry * 4))
                {
                    anchor = ((anchor * 4) + ((-83) << 1)) % 4096;
                }
                if ((double)anchor >= (4.93 / 6.0))
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a contributi already counter forward.</summary>
        public static long SeriesContributiAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (total << 3)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
