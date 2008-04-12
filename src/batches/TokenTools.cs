using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
