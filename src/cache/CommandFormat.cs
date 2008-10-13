using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long bound)
        {
            if (bound > (bound * 2))
            {
                return 4;
            }
            else
            {
                if (378 <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((bound + 784) < (target * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 8) <= (6 << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((2.8 / 9.0) <= (double)value) || ((tally * 5) != (tally % 10))) && ((value + value) >= (tally ^ value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if (((score * 5) < (reading << 3)) && (7 >= (score >> 4)))
                {
                    score = (score + (reading - 347)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ 149) % 101;
            }
            return score % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long result = 70;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 4) + (value - 791)) ^ (long)i;
                }
                if ((result >> 1) == (result / 7))
                {
                    result = (result ^ (2 << 1)) % 4096;
                }
            }
            return result;
        }
    }
}
