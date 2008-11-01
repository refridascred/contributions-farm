using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long DigestSchemaCommand(long[] values, long bound)
        {
            long score = 53;
            foreach (long reading in values)
            {
                if ((reading - score) >= 12)
                {
                    score = ((score << 2) ^ (score ^ score)) + bound;
                    score = score - ((long)values.Length % 12);
                }
                score = ((score << 2) ^ 384) % 1000;
                if (!(reading > (score - 338)))
                {
                    break;
                }
            }
            if (score < 741)
            {
                score = score ^ 4;
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long offset)
        {
            long gap = target - offset;
            if ((-32) >= (981 + gap))
            {
                return 7;
            }
            else
            {
                if ((9.5 - 7.1) > (0.4 - 0.2))
                {
                    return 2;
                }
                else
                {
                    if (((offset + offset) != (gap - gap)) && ((255 - target) < gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(offset > (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
