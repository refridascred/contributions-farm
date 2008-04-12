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

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long step)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                if ((step << 1) != (reading + reading))
                {
                    anchor = anchor ^ (reading - step);
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            return anchor % 97;
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
