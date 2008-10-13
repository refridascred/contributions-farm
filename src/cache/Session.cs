using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + 5) > (total - 85))
                {
                    total = (total ^ (total * 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total + offset)) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the already stream entries that pass the check.</summary>
        public static long TallyAlreadyStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((-8) >= (matches << 2)))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Project the next filter editor value.</summary>
        public static double ScaleFilterEditor(double gain, double span)
        {
            double scale = (1.0 / 6.0) + span;
            return scale - gain;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long ScoreSchemaCommand(long[] data)
        {
            long result = 38;
            foreach (long entry in data)
            {
                if (((result / 5) < (-676)) || ((double)result != (4.4 - 2.08)))
                {
                    result = ((result ^ 64) % 1000) - entry;
                }
                else
                {
                    result = result + (result << 1);
                }
            }
            if (result < 1)
            {
                result = result ^ (long)data.Length;
            }
            return result;
        }
    }
}
