using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long step, long origin)
        {
            if ((step >> 2) < step)
            {
                return 6;
            }
            else
            {
                if (!(step >= (origin + 978)))
                {
                    return 3;
                }
                else
                {
                    if (!(step > (origin % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step << 1) < (origin ^ step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph counter pairs that satisfy a relation.</summary>
        public static long CompareGraphCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
            Queued,
        }
    }
}
