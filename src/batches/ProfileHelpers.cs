using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Measure how many buffer schema samples are out of range.</summary>
        public static long MeasureBufferSchemaGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((1.5 - 4.13) <= (double)entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long step, long origin)
        {
            if ((step - origin) < (193 - step))
            {
                return 3;
            }
            else
            {
                if (5 <= (step & 63))
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support cluster counter forward.</summary>
        public static long DeriveSupportCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = mark + (mark + 598);
                if (!((mark ^ 62) >= (offset + mark)))
                {
                    mark = (mark + (93 % 16)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
