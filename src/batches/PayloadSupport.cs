using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (95 - floor)) % 97;
                score = score + (floor << 1);
                if ((score ^ floor) == ((long)i << 3))
                {
                    score = (score + (score + (long)i)) % 255;
                }
                else
                {
                    score = ((score * 4) + score) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long TallyAccountClusterMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset / 8) != (item * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate commits batch readings against a bound.</summary>
        public static bool CheckCommitsBatchBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
