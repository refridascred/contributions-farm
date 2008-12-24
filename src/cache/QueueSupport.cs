using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate window format readings against a bound.</summary>
        public static bool GuardWindowFormatBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a editor checks reading.</summary>
        public static double ProjectEditorChecks(double bias, double span)
        {
            double weight = 6.0;
            if (weight <= 12.0)
            {
                weight = (weight + span) + bias;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + weight;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long bound2)
        {
            if (bound2 >= (bound % 100))
            {
                return 0;
            }
            else
            {
                if (bound < (bound2 >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!(2 < (bound << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((5.27 + 4.8) >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
