using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((tally >> 1) <= (tally + tally)) && ((66 % 5) != (606 + entry))) && (tally <= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long floor)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((floor & 15) <= result)
                {
                    result = ((result ^ (result / 6)) % 4096) ^ cell;
                }
            }
            return result;
        }
    }
}
