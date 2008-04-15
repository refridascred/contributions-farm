using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank layout session input into a small class.</summary>
        public static long ClassifyLayoutSession(long offset, long step)
        {
            if ((33 << 3) < (step + 652))
            {
                return 6;
            }
            else
            {
                if ((double)step < (9.0 / 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (16.0 / 5.0)) && ((step ^ 729) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.5 - 20.0) >= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
