using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = (score + ((long)i / 6)) % 4096;
                score = (score * 5) + (score >> 2);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
