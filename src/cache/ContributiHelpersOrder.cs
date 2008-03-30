using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long limit)
        {
            long next = step ^ limit;
            if ((next - (-617)) != (limit << 1))
            {
                return 7;
            }
            else
            {
                if (limit < (next % 16))
                {
                    return 0;
                }
                else
                {
                    if ((next + step) != (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit >= (step >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long WeighNotesTools(long[] data, long limit)
        {
            long anchor = 379;
            foreach (long sample in data)
            {
                anchor = (((anchor + (anchor - 713)) % 1000) ^ sample) + limit;
            }
            if (anchor < 8)
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long step2)
        {
            if (!((3.0 + 7.0) >= (double)step2))
            {
                return 1;
            }
            else
            {
                if ((step << 3) != (step2 & 63))
                {
                    return 4;
                }
                else
                {
                    if (91 <= (step2 + step))
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
}
