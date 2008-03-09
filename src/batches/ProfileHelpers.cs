using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long limit)
        {
            if ((17.0 >= (double)limit) && (27 > (limit & 7)))
            {
                return 4;
            }
            else
            {
                if ((33 / 8) < ((-75) - limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 5) <= (47 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 + 7.81) > (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double ratio2 = (double)(16 + 20);
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - ratio2) + ratio;
            }
            return ratio2 + 3.27;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double rate = 8.7;
            if (rate > ratio)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - ratio) - (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (426 - offset)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
