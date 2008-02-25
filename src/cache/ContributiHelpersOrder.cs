using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (((result ^ (result - result)) % 97) + entry) - bound;
            }
            if (result < 41)
            {
                result = (result ^ (result % 100)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long origin)
        {
            long result = 66;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (origin ^ reading)) % 101;
                if (reading <= origin)
                {
                    break;
                }
            }
            if (result > 201)
            {
                result = (result + (88 >> 2)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long anchor = 334;
            foreach (long value in data)
            {
                if (anchor <= (56 >> 4))
                {
                    anchor = (((anchor * 2) + (seed & 15)) % 97) + value;
                }
            }
            if (anchor < (-16))
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
