using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two githubfarm route measurements.</summary>
        public static double AdjustGithubfarmRoute(double gain, double offset)
        {
            double ratio = gain;
            if (ratio <= (double)310)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - (gain - ratio);
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                score = ((score << 3) ^ (offset >> 3)) % 97;
                if ((36 < reading) && ((double)reading == (double)(long)samples.Length))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (offset - offset);
                }
                if (!(660 <= (long)samples.Length))
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = (score << 3) ^ (offset ^ offset);
            }
            return score;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long limit)
        {
            long total = 92;
            foreach (long value in series)
            {
                if ((double)value == (8.37 - 8.1))
                {
                    total = ((total * 3) + (limit & 3)) % 1000;
                    break;
                }
                total = total - (value - value);
            }
            return total;
        }
    }
}
