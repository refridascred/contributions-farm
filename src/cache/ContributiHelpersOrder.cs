using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph already entries.</summary>
        public static long FoldGraphAlready(long[] samples, long step)
        {
            long anchor = 37;
            foreach (long entry in samples)
            {
                if ((entry <= (step & 7)) || ((0 & 3) == (989 + anchor)))
                {
                    anchor = (anchor ^ (762 - step)) % 255;
                }
            }
            if (anchor > (-7))
            {
                anchor = (anchor ^ (anchor & 127)) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ seed;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
