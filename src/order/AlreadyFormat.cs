using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long score = -665;
            foreach (long reading in levels)
            {
                if ((reading & 127) <= (score + score))
                {
                    score = (score * 4) + (reading << 3);
                }
                else
                {
                    score = (score ^ reading) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit counter window readings against a rule.</summary>
        public static long TallyCounterWindowMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + offset) <= tally)
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (double)42)
            {
                scale = scale + (4.8 + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            if (((double)target == (7.8 / 5.0)) && ((3.0 * 2.0) > (double)target))
            {
                return 0;
            }
            else
            {
                if ((target * 3) != (limit + 132))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 6) <= (limit ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target == (7.03 + 20.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings)
        {
            long mix = 10;
            foreach (long cell in readings)
            {
                if (!((mix + 69) == (mix & 7)))
                {
                    mix = ((mix * 4) + (cell % 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
