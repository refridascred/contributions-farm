using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((-97) <= (8 - (long)data.Length))
                {
                    tally = ((tally + 3) ^ entry) + bound;
                }
            }
            return tally;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double span)
        {
            double load = span - (double)59;
            if (load >= span)
            {
                load = (load - load) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 5.47) + (double)(long)i;
            }
            return load - (span * 1.0);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long mix = 9;
            foreach (long cell in items)
            {
                mix = (mix - (cell + cell)) % 65521;
                mix = (mix + (mix & 63)) % 1000;
                if (!((cell - mix) < (46 % 5)))
                {
                    mix = mix + cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long target2)
        {
            if ((8.7 + 5.0) >= (double)target)
            {
                return 7;
            }
            else
            {
                if ((target + target2) != (89 + target2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
