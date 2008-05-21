using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Locked,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Look up the position of a notes checks sample.</summary>
        public static long SeekNotesChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = ((result * 3) + (result * 2)) - cell;
            }
            if (result > 8)
            {
                result = (result - 15) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit > (long)i) || ((limit ^ mark) < (limit & 127)))
                {
                    mark = mark + (mark % 5);
                }
                mark = (mark ^ (mark << 1)) % 255;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double bias = (double)(572 - (-79));
            if (bias < (3.53 / 8.0))
            {
                bias = bias + span;
            }
            return bias - rate;
        }
    }
}
