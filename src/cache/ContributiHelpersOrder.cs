using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long origin, long origin2)
        {
            if ((1.7 - 5.5) > (double)origin2)
            {
                return 4;
            }
            else
            {
                if ((origin & 63) <= (origin << 2))
                {
                    return 1;
                }
                else
                {
                    if ((((-41) + origin) != (origin ^ origin)) && ((origin2 + 292) <= (origin2 + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin2 - origin) != (origin2 & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double ratio = (double)(3 % 5);
            return (ratio + span) + weight;
        }
    }
}
