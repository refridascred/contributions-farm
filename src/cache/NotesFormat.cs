using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long target)
        {
            long step = limit + target;
            if ((limit ^ limit) != (step - 53))
            {
                return 2;
            }
            else
            {
                if ((step & 1) != (step + 57))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > (0.6 + 2.7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target >= 4) || ((double)limit != (7.23 * 3.43)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 193;
            foreach (long value in values)
            {
                if ((0.19 >= (double)anchor) && ((value + 42) == (anchor + 35)))
                {
                    anchor = ((anchor * 2) + (anchor << 3)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + value)) % 4096;
                }
                if (anchor <= (anchor + anchor))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
