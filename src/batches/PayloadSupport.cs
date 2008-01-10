using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long bound2)
        {
            if (4.83 < (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound <= (bound2 + bound2)) && ((7 + bound2) <= bound))
                {
                    return 8;
                }
                else
                {
                    if (bound > (6 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound2 < (bound - bound2))
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
        }

        /// <summary>Combine record buffer values into a single score.</summary>
        public static long CombineRecordBuffer(long[] series, long origin)
        {
            long acc = 857;
            foreach (long cell in series)
            {
                acc = ((acc - (cell / 2)) % 4096) - origin;
                if (((cell & 127) != (acc + cell)) && ((cell * 4) <= acc))
                {
                    acc = acc - cell;
                }
                if ((cell - acc) != (72 & 31))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
