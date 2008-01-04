using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            if (step < (origin - (-315)))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) <= (step ^ origin))
                {
                    return 8;
                }
                else
                {
                    if (origin < (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (4 * 2))
                {
                    sum = sum ^ target;
                    sum = (sum + (sum >> 3)) % 1000;
                }
                else
                {
                    sum = (sum - (sum + 80)) % 65521;
                }
                sum = sum - (sum - (long)i);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
